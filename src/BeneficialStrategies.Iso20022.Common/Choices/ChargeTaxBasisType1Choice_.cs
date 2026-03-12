// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the charge tax basis.
    /// </summary>
    [KnownType(typeof(ChargeTaxBasisType1Choice.Code))]
    [KnownType(typeof(ChargeTaxBasisType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeTaxBasisType1Choice.Code),nameof(ChargeTaxBasisType1Choice.Code))]
    [JsonDerivedType(typeof(ChargeTaxBasisType1Choice.Proprietary),nameof(ChargeTaxBasisType1Choice.Proprietary))]
    [IsoId("_AdIdYtokEeC60axPepSq7g_397232246")]
    [DisplayName("Charge Tax Basis Type 1 Choice")]
    public abstract partial record ChargeTaxBasisType1Choice_
    {
    }
}
