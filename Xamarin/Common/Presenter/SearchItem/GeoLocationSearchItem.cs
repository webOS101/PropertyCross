﻿using System;
using PropertyFinder.Model;

namespace PropertyFinder.Presenter
{
  /// <summary>
  /// Represents a search against a geo-location.
  /// </summary>
  public class GeoLocationSearchItem : SearchItemBase
  {
    public GeoLocation Location { get; set; }

    public GeoLocationSearchItem()
    {
    }

    public GeoLocationSearchItem(GeoLocation location)
    {
      Location = location;
      DisplayText = string.Format("{0:F2}, {1:F2}", location.Latitude, location.Longitude);
    }

    public override void FindProperties(PropertyDataSource dataSource,
      int pageNumber, Action<PropertyDataSourceResult> callback)
    {
      dataSource.FindProperties(Location.Latitude, Location.Longitude, 1, callback);
    }
  }
}
