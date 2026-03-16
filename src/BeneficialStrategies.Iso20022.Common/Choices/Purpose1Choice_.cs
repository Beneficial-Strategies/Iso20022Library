// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying reason for the payment transaction.||Usage: Purpose is used by the end-customers, i.e. initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(Purpose1Choice.Code))]
    [KnownType(typeof(Purpose1Choice.Proprietary))]
    [JsonDerivedType(typeof(Purpose1Choice.Code), nameof(Purpose1Choice.Code))]
    [JsonDerivedType(typeof(Purpose1Choice.Proprietary), nameof(Purpose1Choice.Proprietary))]
    [IsoId("_PrK9gNp-Ed-ak6NoX_4Aeg_-891374754")]
    [DisplayName("Purpose 1 Choice")]
    public abstract record Purpose1Choice_ { }
}
