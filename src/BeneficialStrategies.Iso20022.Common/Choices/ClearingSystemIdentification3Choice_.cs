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
    /// Specifies the clearing system identification.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification3Choice.Code))]
    [KnownType(typeof(ClearingSystemIdentification3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingSystemIdentification3Choice.Code),nameof(ClearingSystemIdentification3Choice.Code))]
    [JsonDerivedType(typeof(ClearingSystemIdentification3Choice.Proprietary),nameof(ClearingSystemIdentification3Choice.Proprietary))]
    #endif
    [IsoId("_TMVXJdp-Ed-ak6NoX_4Aeg_948374898")]
    [DisplayName("Clearing System Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingSystemIdentification3Choice_
    #else
    public abstract partial class ClearingSystemIdentification3Choice_
    #endif
    {
    }
}
