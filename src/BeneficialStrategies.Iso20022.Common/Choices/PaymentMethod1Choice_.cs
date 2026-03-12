// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Method of payment for the remittance of the CSD or the NCB to the invoicing party.
    /// </summary>
    [KnownType(typeof(PaymentMethod1Choice.Code))]
    [KnownType(typeof(PaymentMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentMethod1Choice.Code),nameof(PaymentMethod1Choice.Code))]
    [JsonDerivedType(typeof(PaymentMethod1Choice.Proprietary),nameof(PaymentMethod1Choice.Proprietary))]
    [IsoId("_jFLkUu5NEeCisYr99QEiWA_-1587075302")]
    [DisplayName("Payment Method 1 Choice")]
    public abstract partial record PaymentMethod1Choice_
    {
    }
}
