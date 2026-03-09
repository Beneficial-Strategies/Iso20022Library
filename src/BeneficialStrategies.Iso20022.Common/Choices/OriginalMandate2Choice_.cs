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
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate2Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate2Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate2Choice.OriginalMandateIdentification),nameof(OriginalMandate2Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate2Choice.OriginalMandate),nameof(OriginalMandate2Choice.OriginalMandate))]
    #endif
    [IsoId("_to8xYVkyEeGeoaLUQk__nA_-1304460970")]
    [DisplayName("Original Mandate 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate2Choice_
    #else
    public abstract partial class OriginalMandate2Choice_
    #endif
    {
    }
}
