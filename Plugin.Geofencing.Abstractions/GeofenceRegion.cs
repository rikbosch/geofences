﻿using System;


namespace Plugin.Geofencing
{
    public class GeofenceRegion
    {
        public GeofenceRegion(string identifier, Position center, Distance radius)
        {
            this.Identifier = identifier;
            this.Center = center;
            this.Radius = radius;
        }


        public string Identifier { get; }
        public Position Center { get; }
        public Distance Radius { get; }


        public override bool Equals(object obj) => this.Identifier.Equals(obj);
        public override int GetHashCode() => this.Identifier.GetHashCode();
    }
}
