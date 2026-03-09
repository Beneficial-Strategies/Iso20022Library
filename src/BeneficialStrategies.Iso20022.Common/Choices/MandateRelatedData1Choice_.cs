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
    [KnownType(typeof(MandateRelatedData1Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData1Choice.CreditTransferMandate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MandateRelatedData1Choice.DirectDebitMandate),nameof(MandateRelatedData1Choice.DirectDebitMandate))]
    [JsonDerivedType(typeof(MandateRelatedData1Choice.CreditTransferMandate),nameof(MandateRelatedData1Choice.CreditTransferMandate))]
    #endif
    [IsoId("_su3YJ8lxEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Related Data 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateRelatedData1Choice_
    #else
    public abstract partial class MandateRelatedData1Choice_
    #endif
    {
    }
}
