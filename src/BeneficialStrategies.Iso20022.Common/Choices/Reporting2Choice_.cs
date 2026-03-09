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
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting2Choice.Code))]
    [KnownType(typeof(Reporting2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reporting2Choice.Code),nameof(Reporting2Choice.Code))]
    [JsonDerivedType(typeof(Reporting2Choice.Proprietary),nameof(Reporting2Choice.Proprietary))]
    #endif
    [IsoId("_Qs45Mtp-Ed-ak6NoX_4Aeg_-349062494")]
    [DisplayName("Reporting 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reporting2Choice_
    #else
    public abstract partial class Reporting2Choice_
    #endif
    {
    }
}
