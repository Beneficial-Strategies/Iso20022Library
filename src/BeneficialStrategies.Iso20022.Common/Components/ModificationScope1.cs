// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_REb2h9p-Ed-ak6NoX_4Aeg_1783626539")]
[DisplayName("Modification Scope")]
public record ModificationScope1
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_REb2iNp-Ed-ak6NoX_4Aeg_1783627002")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_RElAcNp-Ed-ak6NoX_4Aeg_1327470342")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public required PostalAddress3 PostalAddress { get; init; }
}
