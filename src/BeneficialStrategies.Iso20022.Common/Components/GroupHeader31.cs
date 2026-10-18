// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader31"/>
[IsoId("_PrK9iNp-Ed-ak6NoX_4Aeg_-727218247")]
[DisplayName("Group Header")]
public partial record GroupHeader31
{
    /// <inheritdoc cref="IGroupHeader31.MessageIdentification"/>
    [IsoId("_PrUugNp-Ed-ak6NoX_4Aeg_-726298236")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader31.CreationDateTime"/>
    [IsoId("_PrUugdp-Ed-ak6NoX_4Aeg_-726298215")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader31.Authorisation"/>
    [IsoId("_PrUugtp-Ed-ak6NoX_4Aeg_263177191")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader31.InitiatingParty"/>
    [IsoId("_PrUug9p-Ed-ak6NoX_4Aeg_-726298169")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader31.InstructingAgent"/>
    [IsoId("_PrUuhNp-Ed-ak6NoX_4Aeg_-726298030")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader31.InstructedAgent"/>
    [IsoId("_PrUuhdp-Ed-ak6NoX_4Aeg_-726298061")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
