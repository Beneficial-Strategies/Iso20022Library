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
    [KnownType(typeof(OriginalMandate9Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate9Choice.OriginalMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OriginalMandate9Choice.OriginalMandateIdentification),nameof(OriginalMandate9Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate9Choice.OriginalMandate),nameof(OriginalMandate9Choice.OriginalMandate))]
    #endif
    [IsoId("_d_uM-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate9Choice_
    #else
    public abstract partial class OriginalMandate9Choice_
    #endif
    {
    }
}
