// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Control Header7.
/// </summary>
[IsoId("_xo_pMTEyEe6g-ffJsqGiSA")]
[DisplayName("Currency Control Header7")]
public record CurrencyControlHeader7
{
    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required Max35Text MessageIdentification { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required ISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Number Of Items.
    /// </summary>
    [DisplayName("Number Of Items")]
    [IsoXmlTag("NbOfItms")]
    public required Max15NumericText NumberOfItems { get; init; }

    /// <summary>
    /// Receiving Party.
    /// </summary>
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty")]
    public required PartyIdentification272 ReceivingParty { get; init; }

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; }
}
