// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for the underlying master agreement.
    /// </summary>
    [KnownType(typeof(AgreementFramework1Choice.AgreementFramework))]
    [KnownType(typeof(AgreementFramework1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(AgreementFramework1Choice.AgreementFramework),nameof(AgreementFramework1Choice.AgreementFramework))]
    [JsonDerivedType(typeof(AgreementFramework1Choice.ProprietaryIdentification),nameof(AgreementFramework1Choice.ProprietaryIdentification))]
    [IsoId("_UkZWTNp-Ed-ak6NoX_4Aeg_863321778")]
    [DisplayName("Agreement Framework 1 Choice")]
    public abstract partial record AgreementFramework1Choice_
    {
    }
}
