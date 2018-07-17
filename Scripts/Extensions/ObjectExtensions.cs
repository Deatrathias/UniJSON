﻿using System;

namespace UniJSON
{
    public static class ObjectExtensions
    {
        public static Object GetValue(this Object self, String key)
        {
            var t = self.GetType();
            var fi = t.GetField(key);
            if (fi != null)
            {
                return fi.GetValue(self);
            }

            var pi = t.GetProperty(key);
            if (pi != null)
            {
                return fi.GetValue(self);
            }

            throw new ArgumentException();
        }
    }
}
