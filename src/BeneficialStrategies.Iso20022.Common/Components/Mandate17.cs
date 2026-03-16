// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_eBVWgdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate")]
public record Mandate17
{
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_eCqzRdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    [IsoId("_eCqzR9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    [IsoId("_eCqzSdcZEeqRFcf2R4bPBw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_eCqzS9cZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_eCqzTdcZEeqRFcf2R4bPBw")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences5? Occurrences { get; init; }

    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    [IsoId("_eCqzT9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    [IsoId("_eCqzUdcZEeqRFcf2R4bPBw")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_eCqzU9cZEeqRFcf2R4bPBw")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_eCqzVdcZEeqRFcf2R4bPBw")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    [IsoId("_eCqzV9cZEeqRFcf2R4bPBw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    [IsoId("_eCqzWdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_eCqzW9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_eCqzXdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_eCqzX9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_eCqzYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_eCqzY9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_eCqzZdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_eCqzZ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_eCqzadcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_eCqza9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    [IsoId("_eCqzbdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_eCqzb9cZEeqRFcf2R4bPBw")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredMandateDocument1? ReferredDocument { get; init; }
}
