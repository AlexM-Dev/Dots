using System;
using System.Collections.Generic;
using PhysicsCore;
using System.IO;
using System.Reflection;

namespace Dots {
    public class PhysicsSelector {
        public List<PhysicsSet> Sets { get; set; }
        public PhysicsSet SelectedSet { get; set; }
        public PhysicsSet Select(string name) {
            foreach (PhysicsSet set in Sets) {
                if (set.Name == name) { return set; }
            }
            return null;
        }
        public PhysicsSelector() {
            Sets = new List<PhysicsSet>();

            string path = Environment.CurrentDirectory + @"\";

            foreach (string s in Directory.GetFiles(path, "*.dll")) {
                Assembly.LoadFile(s);
            }
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (Type t in a.GetTypes()) {
                    if (t.GetInterface("PhysicsCore.PhysicsSet") != null) {
                        try {
                            PhysicsSet set = Activator.CreateInstance(t) as PhysicsSet;
                            Sets.Add(set);
                        } catch { }
                    }
                }
            }

            SelectedSet = Sets[0];
        }
    }
}
