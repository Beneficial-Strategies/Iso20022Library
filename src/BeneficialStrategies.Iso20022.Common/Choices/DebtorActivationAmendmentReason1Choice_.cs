// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the amendment of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(DebtorActivationAmendmentReason1Choice.Code))]
    [KnownType(typeof(DebtorActivationAmendmentReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(DebtorActivationAmendmentReason1Choice.Code),nameof(DebtorActivationAmendmentReason1Choice.Code))]
    [JsonDerivedType(typeof(DebtorActivationAmendmentReason1Choice.Proprietary),nameof(DebtorActivationAmendmentReason1Choice.Proprietary))]
    [IsoId("_bjMUbvGAEemQ7oqCO5NTQw")]
    [DisplayName("Debtor Activation Amendment Reason 1 Choice")]
    public abstract partial record DebtorActivationAmendmentReason1Choice_
    {
    }
}
