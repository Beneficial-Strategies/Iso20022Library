// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for settle style.
    /// </summary>
    [KnownType(typeof(SettleStyle2Choice.Code))]
    [KnownType(typeof(SettleStyle2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettleStyle2Choice.Code),nameof(SettleStyle2Choice.Code))]
    [JsonDerivedType(typeof(SettleStyle2Choice.Proprietary),nameof(SettleStyle2Choice.Proprietary))]
    #endif
    [IsoId("_rPPgweLaEeWFtOV72FbX9w")]
    [DisplayName("Settle Style 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettleStyle2Choice_
    #else
    public abstract partial class SettleStyle2Choice_
    #endif
    {
    }
}
