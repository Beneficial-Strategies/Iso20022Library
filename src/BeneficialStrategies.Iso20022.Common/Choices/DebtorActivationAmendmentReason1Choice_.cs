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
    /// Specifies the reason for the amendment of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(DebtorActivationAmendmentReason1Choice.Code))]
    [KnownType(typeof(DebtorActivationAmendmentReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DebtorActivationAmendmentReason1Choice.Code),nameof(DebtorActivationAmendmentReason1Choice.Code))]
    [JsonDerivedType(typeof(DebtorActivationAmendmentReason1Choice.Proprietary),nameof(DebtorActivationAmendmentReason1Choice.Proprietary))]
    #endif
    [IsoId("_bjMUbvGAEemQ7oqCO5NTQw")]
    [DisplayName("Debtor Activation Amendment Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DebtorActivationAmendmentReason1Choice_
    #else
    public abstract partial class DebtorActivationAmendmentReason1Choice_
    #endif
    {
    }
}
