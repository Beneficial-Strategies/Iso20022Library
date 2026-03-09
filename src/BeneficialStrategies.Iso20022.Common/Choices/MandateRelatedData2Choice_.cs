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
    /// Choice of mandate related information.
    /// </summary>
    [KnownType(typeof(MandateRelatedData2Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData2Choice.CreditTransferMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MandateRelatedData2Choice.DirectDebitMandate),nameof(MandateRelatedData2Choice.DirectDebitMandate))]
    [JsonDerivedType(typeof(MandateRelatedData2Choice.CreditTransferMandate),nameof(MandateRelatedData2Choice.CreditTransferMandate))]
    #endif
    [IsoId("_a24zwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Data 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateRelatedData2Choice_
    #else
    public abstract partial class MandateRelatedData2Choice_
    #endif
    {
    }
}
