// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the requested authority investigation information details.
/// </summary>
[IsoId("_zIYkA01JEeGAs6v-iSb2RQ")]
[DisplayName("Authority Investigation")]
public record AuthorityInvestigation2
{
    /// <summary>
    /// Identifies the type requested information as a code.
    /// </summary>
    [IsoId("_1ur36E1JEeGAs6v-iSb2RQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AuthorityRequestType1 Type { get; init; }

    /// <summary>
    /// Identifies the roles the customer plays in the requested information.
    /// </summary>
    [IsoId("_sGeWoU1AEeGAs6v-iSb2RQ")]
    [DisplayName("Investigated Roles")]
    [IsoXmlTag("InvstgtdRoles")]
    public required InvestigatedParties1Choice_ InvestigatedRoles { get; init; }

    /// <summary>
    /// Specifies the additional investigated parties.
    /// </summary>
    [IsoId("_80akgU1JEeGAs6v-iSb2RQ")]
    [DisplayName("Additional Investigated Parties")]
    [IsoXmlTag("AddtlInvstgtdPties")]
    public InvestigatedParties1Choice_? AdditionalInvestigatedParties { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the requested information.
    /// </summary>
    [IsoId("_6sOI8U1JEeGAs6v-iSb2RQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }
}
