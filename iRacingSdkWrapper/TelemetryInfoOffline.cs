using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iRSDKSharp;
using iRacingSdkWrapper.Bitfields;

namespace iRacingSdkWrapper
{
    public class TelemetryInfoOffline : TelemetryInfo
    {
        public TelemetryInfoOffline(iRacingSDK sdk)
            : base(sdk)
        {
        }

        public override IEnumerable<TelemetryValue> GetValues()
        {
            return new TelemetryValue[] { 
                this.SessionTime,
                this.SessionNum,
                this.SessionState,
                this.SessionUniqueID,
                this.SessionTimeRemain,
                this.SessionLapsRemain,
                this.DriverMarker,
                this.FrameRate,
                this.CpuUsageBG,
                this.OnPitRoad,
                this.SteeringWheelAngle,
                this.Throttle,
                this.Brake,
                this.Clutch,
                this.Gear,
                this.RPM,
                this.Lap,
                this.LapDist,
                this.LapDistPct,
                this.LapBestLap,
                this.LapBestLapTime,
                this.LapLastLapTime,
                this.LapCurrentLapTime,
                this.LapDeltaToBestLap,
                this.LapDeltaToBestLap_DD,
                this.LapDeltaToBestLap_OK,
                this.LapDeltaToOptimalLap,
                this.LapDeltaToOptimalLap_DD,
                this.LapDeltaToOptimalLap_OK,
                this.LapDeltaToSessionBestLap,
                this.LapDeltaToSessionBestLap_DD,
                this.LapDeltaToSessionBestLap_OK,
                this.LapDeltaToSessionOptimalLap,
                this.LapDeltaToSessionOptimalLap_DD,
                this.LapDeltaToSessionOptimalLap_OK,
                this.LapDeltaToSessionLastlLap,
                this.LapDeltaToSessionLastlLap_DD,
                this.LapDeltaToSessionLastlLap_OK,
                this.LongAccel,
                this.LatAccel,
                this.VertAccel,
                this.RollRate,
                this.PitchRate,
                this.YawRate,
                this.Speed,
                this.VelocityX,
                this.VelocityY,
                this.VelocityZ,
                this.Yaw,
                this.Pitch,
                this.Roll,
                this.Lat,
                this.Lon,
                this.Alt,
                this.TrackTemp,
                this.AirTemp,
                this.PitRepairLeft,
                this.PitOptRepairLeft,
                this.IsOnTrack,
                this.SteeringWheelTorque,
                this.SteeringWheelPctTorque,
                this.SteeringWheelPctTorqueSign,
                this.SteeringWheelPctTorqueSignStops,
                this.SteeringWheelPctDamper,
                this.SteeringWheelAngleMax,
                this.ShiftIndicatorPct,
                this.ShiftPowerPct,
                this.ShiftGrindRPM,
                this.ThrottleRaw,
                this.BrakeRaw,
                this.EngineWarnings,
                this.FuelLevel,
                this.FuelLevelPct,
                this.WaterTemp,
                this.WaterLevel,
                this.FuelPress,
                this.OilTemp,
                this.OilPress,
                this.OilLevel,
                this.Voltage,
                this.ManifoldPress,
                this.RRbrakeLinePress,
                this.RRspeed,
                this.RRpressure,
                this.RRcoldPressure,
                this.RRtempL,
                this.RRtempM,
                this.RRtempR,
                this.RRtempCL,
                this.RRtempCM,
                this.RRtempCR,
                this.RRwearL,
                this.RRwearM,
                this.RRwearR,
                this.LRbrakeLinePress,
                this.LRspeed,
                this.LRpressure,
                this.LRcoldPressure,
                this.LRtempL,
                this.LRtempM,
                this.LRtempR,
                this.LRtempCL,
                this.LRtempCM,
                this.LRtempCR,
                this.LRwearL,
                this.LRwearM,
                this.LRwearR,
                this.RFbrakeLinePress,
                this.RFspeed,
                this.RFpressure,
                this.RFcoldPressure,
                this.RFtempL,
                this.RFtempM,
                this.RFtempR,
                this.RFtempCL,
                this.RFtempCM,
                this.RFtempCR,
                this.RFwearL,
                this.RFwearM,
                this.RFwearR,
                this.LFbrakeLinePress,
                this.LFspeed,
                this.LFpressure,
                this.LFcoldPressure,
                this.LFtempL,
                this.LFtempM,
                this.LFtempR,
                this.LFtempCL,
                this.LFtempCM,
                this.LFtempCR,
                this.LFwearL,
                this.LFwearM,
                this.LFwearR,
                this.RRshockDefl,
                this.LRshockDefl,
                this.RFshockDefl,
                this.LFshockDefl,
                this.LFrideHeight,
                this.RFrideHeight,
                this.LRrideHeight,
                this.RRrideHeight};
        }

        /// <summary>
        /// Seconds left till session ends.
        /// </summary>
        public TelemetryValue<double> SessionTimeRemain { get { return GetUndefined<double>("SessionTimeRemain"); } }
        /// <summary>
        /// Laps left till session ends.
        /// </summary>
        public TelemetryValue<int> SessionLapsRemain { get { return GetUndefined<int>("SessionLapsRemain"); } }
        /// <summary>
        /// Average frames per second.
        /// </summary>
        public TelemetryValue<float> FrameRate { get { return GetUndefined<float>("FrameRate"); } }
        /// <summary>
        /// Percent of available tim bg thread took with a 1 sec avg.
        /// </summary>
        public TelemetryValue<float> CpuUsageBG { get { return GetUndefined<float>("CpuUsageBG"); } }
        /// <summary>
        /// Is the player car on pit road between the cones.
        /// </summary>
        public TelemetryValue<bool> OnPitRoad { get { return GetUndefined<bool>("OnPitRoad"); } }
        /// <summary>
        /// Players best lap number.
        /// </summary>
        public TelemetryValue<int> LapBestLap { get { return GetUndefined<int>("LapBestLap"); } }
        /// <summary>
        /// Players best lap time.
        /// </summary>
        public TelemetryValue<float> LapBestLapTime { get { return GetUndefined<float>("LapBestLapTime"); } }
        /// <summary>
        /// Players last lap time.
        /// </summary>
        public TelemetryValue<float> LapLastLapTime { get { return GetUndefined<float>("LapLastLapTime"); } }
        /// <summary>
        /// Estimate of players current lap time as shown in F3 box.
        /// </summary>
        public TelemetryValue<float> LapCurrentLapTime { get { return GetUndefined<float>("LapCurrentLapTime"); } }
        /// <summary>
        /// Delta time for best lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToBestLap { get { return GetUndefined<float>("LapDeltaToBestLap"); } }
        /// <summary>
        /// Rate of change of delta time for best lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToBestLap_DD { get { return GetUndefined<float>("LapDeltaToBestLap_DD"); } }
        /// <summary>
        /// Delta time for best lap is valid.
        /// </summary>
        public TelemetryValue<bool> LapDeltaToBestLap_OK { get { return GetUndefined<bool>("LapDeltaToBestLap_OK"); } }
        /// <summary>
        /// Delta time for optimal lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToOptimalLap { get { return GetUndefined<float>("LapDeltaToOptimalLap"); } }
        /// <summary>
        /// Rate of change of delta time for optimal lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToOptimalLap_DD { get { return GetUndefined<float>("LapDeltaToOptimalLap_DD"); } }
        /// <summary>
        /// Delta time for optimal lap is valid.
        /// </summary>
        public TelemetryValue<bool> LapDeltaToOptimalLap_OK { get { return GetUndefined<bool>("LapDeltaToOptimalLap_OK"); } }
        /// <summary>
        /// Delta time for session best lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionBestLap { get { return GetUndefined<float>("LapDeltaToSessionBestLap"); } }
        /// <summary>
        /// Rate of change of delta time for session best lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionBestLap_DD { get { return GetUndefined<float>("LapDeltaToSessionBestLap_DD"); } }
        /// <summary>
        /// Delta time for session best lap is valid.
        /// </summary>
        public TelemetryValue<bool> LapDeltaToSessionBestLap_OK { get { return GetUndefined<bool>("LapDeltaToSessionBestLap_OK"); } }
        /// <summary>
        /// Delta time for session optimal lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionOptimalLap { get { return GetUndefined<float>("LapDeltaToSessionOptimalLap"); } }
        /// <summary>
        /// Rate of change of delta time for session optimal lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionOptimalLap_DD { get { return GetUndefined<float>("LapDeltaToSessionOptimalLap_DD"); } }
        /// <summary>
        /// Delta time for session optimal lap is valid.
        /// </summary>
        public TelemetryValue<bool> LapDeltaToSessionOptimalLap_OK { get { return GetUndefined<bool>("LapDeltaToSessionOptimalLap_OK"); } }
        /// <summary>
        /// Delta time for session last lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionLastlLap { get { return GetUndefined<float>("LapDeltaToSessionLastlLap"); } }
        /// <summary>
        /// Rate of change of delta time for session last lap.
        /// </summary>
        public TelemetryValue<float> LapDeltaToSessionLastlLap_DD { get { return GetUndefined<float>("LapDeltaToSessionLastlLap_DD"); } }
        /// <summary>
        /// Delta time for session last lap is valid.
        /// </summary>
        public TelemetryValue<bool> LapDeltaToSessionLastlLap_OK { get { return GetUndefined<bool>("LapDeltaToSessionLastlLap_OK"); } }
        /// <summary>
        /// Latitude in decimal degrees.
        /// </summary>
        public TelemetryValue<double> Lat { get { return GetUndefined<double>("Lat"); } }
        /// <summary>
        /// Longitude in decimal degrees.
        /// </summary>
        public TelemetryValue<double> Lon { get { return GetUndefined<double>("Lon"); } }
        /// <summary>
        /// Altitude in meters.
        /// </summary>
        public TelemetryValue<float> Alt { get { return GetUndefined<float>("Alt"); } }
        /// <summary>
        /// Temperature of track at start/finish line.
        /// </summary>
        public TelemetryValue<float> TrackTemp { get { return GetUndefined<float>("TrackTemp"); } }
        /// <summary>
        /// Temperature of air at start/finish line.
        /// </summary>
        public TelemetryValue<float> AirTemp { get { return GetUndefined<float>("AirTemp"); } }
        /// <summary>
        /// Time left for mandatory pit repairs if repairs are active.
        /// </summary>
        public TelemetryValue<float> PitRepairLeft { get { return GetUndefined<float>("PitRepairLeft"); } }
        /// <summary>
        /// Time left for optional repairs if repairs are active.
        /// </summary>
        public TelemetryValue<float> PitOptRepairLeft { get { return GetUndefined<float>("PitOptRepairLeft"); } }
        /// <summary>
        /// Force feedback % max torque on steering shaft signed.
        /// </summary>
        public TelemetryValue<float> SteeringWheelPctTorqueSign { get { return GetUndefined<float>("SteeringWheelPctTorqueSign"); } }
        /// <summary>
        /// Force feedback % max torque on steering shaft signed stops.
        /// </summary>
        public TelemetryValue<float> SteeringWheelPctTorqueSignStops { get { return GetUndefined<float>("SteeringWheelPctTorqueSignStops"); } }
        /// <summary>
        /// Force feedback % max damping.
        /// </summary>
        public TelemetryValue<float> SteeringWheelPctDamper { get { return GetUndefined<float>("SteeringWheelPctDamper"); } }
        /// <summary>
        /// Steering wheel max angle.
        /// </summary>
        public TelemetryValue<float> SteeringWheelAngleMax { get { return GetUndefined<float>("SteeringWheelAngleMax"); } }
        /// <summary>
        /// Friction torque applied to gears when shifting or grinding.
        /// </summary>
        public TelemetryValue<float> ShiftPowerPct { get { return GetUndefined<float>("ShiftPowerPct"); } }
        /// <summary>
        /// RPM of shifter grinding noise.
        /// </summary>
        public TelemetryValue<float> ShiftGrindRPM { get { return GetUndefined<float>("ShiftGrindRPM"); } }
        /// <summary>
        /// Raw throttle input 0=off throttle to 1=full throttle.
        /// </summary>
        public TelemetryValue<float> ThrottleRaw { get { return GetUndefined<float>("ThrottleRaw"); } }
        /// <summary>
        /// Raw brake input 0=brake released to 1=max pedal force.
        /// </summary>
        public TelemetryValue<float> BrakeRaw { get { return GetUndefined<float>("BrakeRaw"); } }
        /// <summary>
        /// Engine manifold pressure.
        /// </summary>
        public TelemetryValue<float> ManifoldPress { get { return GetUndefined<float>("ManifoldPress"); } }
        /// <summary>
        /// RR brake line pressure.
        /// </summary>
        public TelemetryValue<float> RRbrakeLinePress { get { return GetUndefined<float>("RRbrakeLinePress"); } }
        /// <summary>
        /// RR wheel speed.
        /// </summary>
        public TelemetryValue<float> RRspeed { get { return GetUndefined<float>("RRspeed"); } }
        /// <summary>
        /// RR tire pressure.
        /// </summary>
        public TelemetryValue<float> RRpressure { get { return GetUndefined<float>("RRpressure"); } }
        /// <summary>
        /// RR tire cold pressure, as set in the garage.
        /// </summary>
        public TelemetryValue<float> RRcoldPressure { get { return GetUndefined<float>("RRcoldPressure"); } }
        /// <summary>
        /// RR tire left surface temperature.
        /// </summary>
        public TelemetryValue<float> RRtempL { get { return GetUndefined<float>("RRtempL"); } }
        /// <summary>
        /// RR tire middle surface temperature.
        /// </summary>
        public TelemetryValue<float> RRtempM { get { return GetUndefined<float>("RRtempM"); } }
        /// <summary>
        /// RR tire right surface temperature.
        /// </summary>
        public TelemetryValue<float> RRtempR { get { return GetUndefined<float>("RRtempR"); } }
        /// <summary>
        /// RR tire left carcass temperature.
        /// </summary>
        public TelemetryValue<float> RRtempCL { get { return GetUndefined<float>("RRtempCL"); } }
        /// <summary>
        /// RR tire middle carcass temperature.
        /// </summary>
        public TelemetryValue<float> RRtempCM { get { return GetUndefined<float>("RRtempCM"); } }
        /// <summary>
        /// RR tire right carcass temperature.
        /// </summary>
        public TelemetryValue<float> RRtempCR { get { return GetUndefined<float>("RRtempCR"); } }
        /// <summary>
        /// RR tire left percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RRwearL { get { return GetUndefined<float>("RRwearL"); } }
        /// <summary>
        /// RR tire middle percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RRwearM { get { return GetUndefined<float>("RRwearM"); } }
        /// <summary>
        /// RR tire right percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RRwearR { get { return GetUndefined<float>("RRwearR"); } }
        /// <summary>
        /// LR brake line pressure.
        /// </summary>
        public TelemetryValue<float> LRbrakeLinePress { get { return GetUndefined<float>("LRbrakeLinePress"); } }
        /// <summary>
        /// LR wheel speed.
        /// </summary>
        public TelemetryValue<float> LRspeed { get { return GetUndefined<float>("LRspeed"); } }
        /// <summary>
        /// LR tire pressure.
        /// </summary>
        public TelemetryValue<float> LRpressure { get { return GetUndefined<float>("LRpressure"); } }
        /// <summary>
        /// LR tire cold pressure, as set in the garage.
        /// </summary>
        public TelemetryValue<float> LRcoldPressure { get { return GetUndefined<float>("LRcoldPressure"); } }
        /// <summary>
        /// LR tire left surface temperature.
        /// </summary>
        public TelemetryValue<float> LRtempL { get { return GetUndefined<float>("LRtempL"); } }
        /// <summary>
        /// LR tire middle surface temperature.
        /// </summary>
        public TelemetryValue<float> LRtempM { get { return GetUndefined<float>("LRtempM"); } }
        /// <summary>
        /// LR tire right surface temperature.
        /// </summary>
        public TelemetryValue<float> LRtempR { get { return GetUndefined<float>("LRtempR"); } }
        /// <summary>
        /// LR tire left carcass temperature.
        /// </summary>
        public TelemetryValue<float> LRtempCL { get { return GetUndefined<float>("LRtempCL"); } }
        /// <summary>
        /// LR tire middle carcass temperature.
        /// </summary>
        public TelemetryValue<float> LRtempCM { get { return GetUndefined<float>("LRtempCM"); } }
        /// <summary>
        /// LR tire right carcass temperature.
        /// </summary>
        public TelemetryValue<float> LRtempCR { get { return GetUndefined<float>("LRtempCR"); } }
        /// <summary>
        /// LR tire left percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LRwearL { get { return GetUndefined<float>("LRwearL"); } }
        /// <summary>
        /// LR tire middle percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LRwearM { get { return GetUndefined<float>("LRwearM"); } }
        /// <summary>
        /// LR tire right percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LRwearR { get { return GetUndefined<float>("LRwearR"); } }
        /// <summary>
        /// RF brake line pressure.
        /// </summary>
        public TelemetryValue<float> RFbrakeLinePress { get { return GetUndefined<float>("RFbrakeLinePress"); } }
        /// <summary>
        /// RF wheel speed.
        /// </summary>
        public TelemetryValue<float> RFspeed { get { return GetUndefined<float>("RFspeed"); } }
        /// <summary>
        /// RF tire pressure.
        /// </summary>
        public TelemetryValue<float> RFpressure { get { return GetUndefined<float>("RFpressure"); } }
        /// <summary>
        /// RF tire cold pressure, as set in the garage.
        /// </summary>
        public TelemetryValue<float> RFcoldPressure { get { return GetUndefined<float>("RFcoldPressure"); } }
        /// <summary>
        /// RF tire left surface temperature.
        /// </summary>
        public TelemetryValue<float> RFtempL { get { return GetUndefined<float>("RFtempL"); } }
        /// <summary>
        /// RF tire middle surface temperature.
        /// </summary>
        public TelemetryValue<float> RFtempM { get { return GetUndefined<float>("RFtempM"); } }
        /// <summary>
        /// RF tire right surface temperature.
        /// </summary>
        public TelemetryValue<float> RFtempR { get { return GetUndefined<float>("RFtempR"); } }
        /// <summary>
        /// RF tire left carcass temperature.
        /// </summary>
        public TelemetryValue<float> RFtempCL { get { return GetUndefined<float>("RFtempCL"); } }
        /// <summary>
        /// RF tire middle carcass temperature.
        /// </summary>
        public TelemetryValue<float> RFtempCM { get { return GetUndefined<float>("RFtempCM"); } }
        /// <summary>
        /// RF tire right carcass temperature.
        /// </summary>
        public TelemetryValue<float> RFtempCR { get { return GetUndefined<float>("RFtempCR"); } }
        /// <summary>
        /// RF tire left percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RFwearL { get { return GetUndefined<float>("RFwearL"); } }
        /// <summary>
        /// RF tire middle percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RFwearM { get { return GetUndefined<float>("RFwearM"); } }
        /// <summary>
        /// RF tire right percent tread remaining.
        /// </summary>
        public TelemetryValue<float> RFwearR { get { return GetUndefined<float>("RFwearR"); } }
        /// <summary>
        /// LF brake line pressure.
        /// </summary>
        public TelemetryValue<float> LFbrakeLinePress { get { return GetUndefined<float>("LFbrakeLinePress"); } }
        /// <summary>
        /// LF wheel speed.
        /// </summary>
        public TelemetryValue<float> LFspeed { get { return GetUndefined<float>("LFspeed"); } }
        /// <summary>
        /// LF tire pressure.
        /// </summary>
        public TelemetryValue<float> LFpressure { get { return GetUndefined<float>("LFpressure"); } }
        /// <summary>
        /// LF tire cold pressure, as set in the garage.
        /// </summary>
        public TelemetryValue<float> LFcoldPressure { get { return GetUndefined<float>("LFcoldPressure"); } }
        /// <summary>
        /// LF tire left surface temperature.
        /// </summary>
        public TelemetryValue<float> LFtempL { get { return GetUndefined<float>("LFtempL"); } }
        /// <summary>
        /// LF tire middle surface temperature.
        /// </summary>
        public TelemetryValue<float> LFtempM { get { return GetUndefined<float>("LFtempM"); } }
        /// <summary>
        /// LF tire right surface temperature.
        /// </summary>
        public TelemetryValue<float> LFtempR { get { return GetUndefined<float>("LFtempR"); } }
        /// <summary>
        /// LF tire left carcass temperature.
        /// </summary>
        public TelemetryValue<float> LFtempCL { get { return GetUndefined<float>("LFtempCL"); } }
        /// <summary>
        /// LF tire middle carcass temperature.
        /// </summary>
        public TelemetryValue<float> LFtempCM { get { return GetUndefined<float>("LFtempCM"); } }
        /// <summary>
        /// LF tire right carcass temperature.
        /// </summary>
        public TelemetryValue<float> LFtempCR { get { return GetUndefined<float>("LFtempCR"); } }
        /// <summary>
        /// LF tire left percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LFwearL { get { return GetUndefined<float>("LFwearL"); } }
        /// <summary>
        /// LF tire middle percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LFwearM { get { return GetUndefined<float>("LFwearM"); } }
        /// <summary>
        /// LF tire right percent tread remaining.
        /// </summary>
        public TelemetryValue<float> LFwearR { get { return GetUndefined<float>("LFwearR"); } }
        /// <summary>
        /// RR shock deflection.
        /// </summary>
        public TelemetryValue<float> RRshockDefl { get { return GetUndefined<float>("RRshockDefl"); } }
        /// <summary>
        /// LR shock deflection.
        /// </summary>
        public TelemetryValue<float> LRshockDefl { get { return GetUndefined<float>("LRshockDefl"); } }
        /// <summary>
        /// RF shock deflection.
        /// </summary>
        public TelemetryValue<float> RFshockDefl { get { return GetUndefined<float>("RFshockDefl"); } }
        /// <summary>
        /// LF shock deflection.
        /// </summary>
        public TelemetryValue<float> LFshockDefl { get { return GetUndefined<float>("LFshockDefl"); } }
        /// <summary>
        /// LF ride height.
        /// </summary>
        public TelemetryValue<float> LFrideHeight { get { return GetUndefined<float>("LFrideHeight"); } }
        /// <summary>
        /// RF ride height.
        /// </summary>
        public TelemetryValue<float> RFrideHeight { get { return GetUndefined<float>("RFrideHeight"); } }
        /// <summary>
        /// LR ride height.
        /// </summary>
        public TelemetryValue<float> LRrideHeight { get { return GetUndefined<float>("LRrideHeight"); } }
        /// <summary>
        /// RR ride height.
        /// </summary>
        public TelemetryValue<float> RRrideHeight { get { return GetUndefined<float>("RRrideHeight"); } }

        public TelemetryValue<T> GetUndefined<T>(string key) { return new TelemetryValue<T>(sdk, key); }
    }
}