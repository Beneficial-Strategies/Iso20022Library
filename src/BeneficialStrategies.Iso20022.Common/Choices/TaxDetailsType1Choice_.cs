// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of tax type.
    /// </summary>
    [KnownType(typeof(TaxDetailsType1Choice.Type))]
    [KnownType(typeof(TaxDetailsType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxDetailsType1Choice.Type),nameof(TaxDetailsType1Choice.Type))]
    [JsonDerivedType(typeof(TaxDetailsType1Choice.Proprietary),nameof(TaxDetailsType1Choice.Proprietary))]
    [IsoId("_RfQKSNp-Ed-ak6NoX_4Aeg_-192931416")]
    [DisplayName("Tax Details Type 1 Choice")]
    public abstract partial record TaxDetailsType1Choice_
    {
    }
}
