// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[IsoId("_0cExIglIEeGATtfOBToyew_-1928302527")]
[DisplayName("Settlement Type And Additional Parameters")]
public record SettlementTypeAndAdditionalParameters5
{
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_0cExIwlIEeGATtfOBToyew_-1307195363")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_0cExJAlIEeGATtfOBToyew_977815075")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public DeliveryReceiptType2Code? Payment { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_0cExJQlIEeGATtfOBToyew_-1959341265")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_0cExJglIEeGATtfOBToyew_491757042")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Indicates whether the settlement transaction was already sent on the market and that it is only sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    [IsoId("_0cOiIAlIEeGATtfOBToyew_653886573")]
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; }
}
