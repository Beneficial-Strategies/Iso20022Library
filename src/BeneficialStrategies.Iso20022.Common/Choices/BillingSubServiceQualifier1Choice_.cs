// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the qualifier for a subservice.
    /// </summary>
    [KnownType(typeof(BillingSubServiceQualifier1Choice.Code))]
    [KnownType(typeof(BillingSubServiceQualifier1Choice.Proprietary))]
    [JsonDerivedType(typeof(BillingSubServiceQualifier1Choice.Code),nameof(BillingSubServiceQualifier1Choice.Code))]
    [JsonDerivedType(typeof(BillingSubServiceQualifier1Choice.Proprietary),nameof(BillingSubServiceQualifier1Choice.Proprietary))]
    [IsoId("_6PphwJqlEeGSON8vddiWzQ_1042088657")]
    [DisplayName("Billing Sub Service Qualifier 1 Choice")]
    public abstract partial record BillingSubServiceQualifier1Choice_
    {
    }
}
