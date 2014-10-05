using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.MemoryMappedFiles;

namespace iRSDKSharp
{
    public class CiRSDKSubHeader
    {
        //Header offsets
        public const int HSessionStartDateOffset = 112;//0
        public const int HSessionStartTimeOffset = 120;//8
        public const int HSessionEndTimeOffset = 128;//16
        public const int HSessionLapCount = 136;//24
        public const int HSessionRecordCount = 140;//28

        MemoryMappedViewAccessor FileMapView = null;

        public CiRSDKSubHeader(MemoryMappedViewAccessor mapView)
        {
            FileMapView = mapView;
        }

        public DateTime SessionStartDate
        {
        get{
            return new DateTime(1970, 1, 1).AddSeconds(FileMapView.ReadInt32(HSessionStartDateOffset));
 }       }

        public double SessionStartTime
        {
            get { return FileMapView.ReadDouble(HSessionStartTimeOffset); }
        }

        public double SessionEndTime
        {
            get { return FileMapView.ReadDouble(HSessionEndTimeOffset); }
        }

        public int SessionLapCount
        {
            get { return FileMapView.ReadInt32(HSessionLapCount); }
        }

        public int SessionRecordCount
        {
            get { return FileMapView.ReadInt32(HSessionRecordCount); }
        }
    }
}
