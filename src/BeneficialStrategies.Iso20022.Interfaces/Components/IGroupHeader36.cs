// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_P1AO9Np-Ed-ak6NoX_4Aeg_650011444")]
public interface IGroupHeader36 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_P1AO9dp-Ed-ak6NoX_4Aeg_650011446")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_P1AO9tp-Ed-ak6NoX_4Aeg_650011505")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// Party that initiates the status message.
    /// </summary>
    [IsoId("_P1AO99p-Ed-ak6NoX_4Aeg_650011599")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification32? InitiatingParty { get; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_P1AO-Np-Ed-ak6NoX_4Aeg_650011900")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    IBranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_P1J_8Np-Ed-ak6NoX_4Aeg_650012114")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification4? DebtorAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_P1J_8dp-Ed-ak6NoX_4Aeg_650011961")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification4? CreditorAgent { get; }
}
