// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the billing rate identification code.
    /// </summary>
    [KnownType(typeof(BillingRateIdentification1Choice.Code))]
    [KnownType(typeof(BillingRateIdentification1Choice.Proprietary))]
    [JsonDerivedType(typeof(BillingRateIdentification1Choice.Code),nameof(BillingRateIdentification1Choice.Code))]
    [JsonDerivedType(typeof(BillingRateIdentification1Choice.Proprietary),nameof(BillingRateIdentification1Choice.Proprietary))]
    [IsoId("_6Q10hpqlEeGSON8vddiWzQ_1451899054")]
    [DisplayName("Billing Rate Identification 1 Choice")]
    public abstract partial record BillingRateIdentification1Choice_
    {
    }
}
