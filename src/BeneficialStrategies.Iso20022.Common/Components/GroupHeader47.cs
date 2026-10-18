// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader47"/>
[IsoId("_s3oCIFkyEeGeoaLUQk__nA_-839305610")]
[DisplayName("Group Header")]
public partial record GroupHeader47
{
    /// <inheritdoc cref="IGroupHeader47.MessageIdentification"/>
    [IsoId("_s3oCIVkyEeGeoaLUQk__nA_1542027670")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader47.CreationDateTime"/>
    [IsoId("_s3xzIFkyEeGeoaLUQk__nA_431116251")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader47.Authorisation"/>
    [IsoId("_s37kIFkyEeGeoaLUQk__nA_1704157201")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader47.InitiatingParty"/>
    [IsoId("_s4EuEFkyEeGeoaLUQk__nA_1970233")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader47.InstructingAgent"/>
    [IsoId("_s4OfEFkyEeGeoaLUQk__nA_-1022013049")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader47.InstructedAgent"/>
    [IsoId("_s4OfEVkyEeGeoaLUQk__nA_989269376")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
