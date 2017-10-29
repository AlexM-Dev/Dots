using System;
using System.Collections.Generic;
using PhysicsCore;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static PhysicsCore.Dot;

namespace Dots {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        private Config cfg = new Config();
        private PhysicsSelector selector = new PhysicsSelector();
        // Particle colour; 82, 82, 82
        private void frmMain_Load(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
            foreach (var set in selector.Sets) {
                cbxPhysics.Items.Add(set.Name);
            }
            cbxPhysics.SelectedIndex = 0;
        }
        protected override void OnPaint(PaintEventArgs e) {
            // Redraw.
            Graphics gr = e.Graphics;
            gr.Clear(BackColor);
            foreach (Dot p in cfg.Particles) {
                int r = cfg.r.Next(255); // 82, 82, 82
                int g = cfg.r.Next(255);
                int b = cfg.r.Next(255);
                Color c = chkRainbow.Checked ?
                    Color.FromArgb(cfg.r.Next(255), cfg.r.Next(255), cfg.r.Next(255)) : p.c;
                Dot clone = p.Clone();
                clone.c = c;
                clone.Draw(gr);
                // g.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), p, closestPoint(p, particles));
            }
            if (cfg.DrawStats) {
                gr.DrawString("Particles: " + cfg.Particles.Count,
                    new Font("Arial", 10), Brushes.White, new PointF(0, 0));
                gr.DrawString("FPS: " + FPS.CalculateFrameRate(),
                    new Font("Arial", 10), Brushes.White, new PointF(0, 12));
                gr.DrawString("Spawn Amount: " + cfg.SpawnAmount,
                    new Font("Arial", 10), Brushes.White, new PointF(0, 24));
                gr.DrawString("Speed: " + cfg.MoveValue,
                    new Font("Arial", 10), Brushes.White, new PointF(0, 36));
                gr.DrawString("Size: " + cfg.SpawnSize,
                    new Font("Arial", 10), Brushes.White, new PointF(0, 48));
                gr.DrawString("Selected PhysicsSet: ",
                    new Font("Arial", 10), Brushes.White, new PointF(0, 72));
                gr.DrawString(selector.SelectedSet.Name + 
                    " - " + selector.SelectedSet.Description,
                    new Font("Arial", 10), Brushes.White, new PointF(4, 84));
            }
            base.OnPaint(e);
        }
        private void moveParticles() {
            List<Dot> newParticles = new List<Dot>();
            foreach (Dot p in cfg.Particles) {
                if (p == null) { continue; }
                if (p.UUID == null) { continue; }
                Dot selectedDot = selector.SelectedSet.GetDot(p, cfg);
                Point closest = selectedDot.p;
                if (closest.IsEmpty) {
                    continue;
                }

                selector.SelectedSet.ApplyPhysics(p, selectedDot, cfg);

                if (p.p == Point.Empty) { continue; }
                if (!(p.p.X <= Width && p.p.X > 0)) { continue; }
                if (!(p.p.Y <= Height && p.p.Y > 0)) { continue; }

                newParticles.Add(p);
            }
            cfg.Particles = newParticles;
        }

        private void addRandomPoints(int iterations) {
            for (int i = 0; i < iterations; i++) {
                int x = cfg.r.Next(0, Width);
                int y = cfg.r.Next(0, Height);
                cfg.Particles.Add(new Dot(new Point(x, y), cfg.ParticleColor,
                    new Size(cfg.SpawnSize, cfg.SpawnSize),
                    (Shape)Convert.ToInt32(chkRound.Checked),
                    (FillMode)Convert.ToInt32(chkFillObjects.Checked)));
            }
        }
        private void tmrMain_Tick(object sender, EventArgs e) {
            moveParticles();
            addRandomPoints(cfg.SpawnAmount);
            Invalidate();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.F11:
                    if (this.FormBorderStyle == FormBorderStyle.None) {
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                        this.WindowState = FormWindowState.Normal;
                    } else {
                        this.WindowState = FormWindowState.Normal;
                        this.FormBorderStyle = FormBorderStyle.None;
                        this.WindowState = FormWindowState.Maximized;
                    }
                    this.BringToFront();
                    break;
                case Keys.F10:
                    cfg.DrawStats = !cfg.DrawStats;
                    foreach (Control c in this.Controls) {
                        c.Visible = cfg.DrawStats;
                    }
                    break;
            }
        }
        private void tmrClick_Tick(object sender, EventArgs e) {
            cfg.Particles.Add(new Dot(PointToClient(Cursor.Position), cfg.ParticleColor,
                    new Size(cfg.SpawnSize, cfg.SpawnSize),
                    (Shape)Convert.ToInt32(chkRound.Checked),
                    (FillMode)Convert.ToInt32(chkFillObjects.Checked)));
        }
        private void frmMain_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                tmrClick.Start();
            }
        }
        private void frmMain_MouseUp(object sender, MouseEventArgs e) {
            tmrClick.Stop();
        }

        private void btnColour_Click(object sender, EventArgs e) {
            using (ColorDialog cd = new ColorDialog()) {
                if (cd.ShowDialog() == DialogResult.OK) {
                    cfg.ParticleColor = cd.Color;
                }
            }
        }

        private void cbxPhysics_SelectedIndexChanged(object sender, EventArgs e) {
            selector.SelectedSet = selector.Sets[cbxPhysics.SelectedIndex];
        }

        private void nudSpawnAmount_ValueChanged(object sender, EventArgs e) {
            cfg.SpawnAmount = (int)nudSpawnAmount.Value;
        }

        private void nudSize_ValueChanged(object sender, EventArgs e) {
            cfg.SpawnSize = (int)nudSize.Value;
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e) {
            cfg.MoveValue = (int)nudSpeed.Value;
        }
    }
}
