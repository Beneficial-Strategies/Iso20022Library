// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cheque21.
/// </summary>
[IsoId("_0U1mgRwMEe6O0NdiBuX__w")]
[DisplayName("Cheque21")]
public record Cheque21
{
    /// <summary>
    /// Drawee Identification.
    /// </summary>
    [DisplayName("Drawee Identification")]
    [IsoXmlTag("DrweeId")]
    public FinancialInstitutionIdentification15? DraweeIdentification { get; init; }

    /// <summary>
    /// Drawer Identification.
    /// </summary>
    [DisplayName("Drawer Identification")]
    [IsoXmlTag("DrwrId")]
    public PartyIdentification139? DrawerIdentification { get; init; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Payee Identification.
    /// </summary>
    [DisplayName("Payee Identification")]
    [IsoXmlTag("PyeeId")]
    public required PartyIdentification139 PayeeIdentification { get; init; }
}
