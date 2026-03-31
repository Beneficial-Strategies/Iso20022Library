// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to the local undertaking.
/// </summary>
[IsoId("_PjZ-2379EeGvEbxvurqpIg")]
[DisplayName("Undertaking")]
public record Undertaking11
{
    /// <summary>
    /// Details related to the requested new amount for the local undertaking.
    /// </summary>
    [IsoId("_PjZ-5X79EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Amount")]
    [IsoXmlTag("NewUdrtkgAmt")]
    public UndertakingAmount2? NewUndertakingAmount { get; init; }

    /// <summary>
    /// Details related to the requested new expiry terms for the local undertaking.
    /// </summary>
    [IsoId("_PjZ-4H79EeGvEbxvurqpIg")]
    [DisplayName("New Expiry Details")]
    [IsoXmlTag("NewXpryDtls")]
    public ExpiryDetails1? NewExpiryDetails { get; init; }

    /// <summary>
    /// Details related to the requested new beneficiary for the local undertaking.
    /// </summary>
    [IsoId("_Z7SjNX7-EeGvEbxvurqpIg")]
    [DisplayName("New Beneficiary")]
    [IsoXmlTag("NewBnfcry")]
    public PartyIdentification43? NewBeneficiary { get; init; }

    /// <summary>
    /// Details related to the requested new terms and conditions for the local undertaking.
    /// </summary>
    [IsoId("_4Bx1oH7-EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Terms And Conditions")]
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    public Narrative1? NewUndertakingTermsAndConditions { get; init; }

    /// <summary>
    /// Details related to the delivery channel for the amended local undertaking.
    /// </summary>
    [IsoId("_KR6lIH7_EeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public CommunicationChannel1? DeliveryChannel { get; init; }
}
