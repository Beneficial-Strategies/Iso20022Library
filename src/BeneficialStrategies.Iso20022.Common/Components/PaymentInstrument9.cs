// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_SBq61dp-Ed-ak6NoX_4Aeg_473679007")]
[DisplayName("Payment Instrument")]
public partial record PaymentInstrument9
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SBq61tp-Ed-ak6NoX_4Aeg_473679025")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Cash account to credit for the payment of the dividends or of the redeemed investments funds.
    /// </summary>
    [IsoId("_SBq619p-Ed-ak6NoX_4Aeg_473679501")]
    [DisplayName("Cash Account Details")]
    [IsoXmlTag("CshAcctDtls")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CashAccount4> CashAccountDetails { get; init; } = new ValueList<CashAccount4>(){};
    
    /// <summary>
    /// Settlement instructions for a payment by cheque.
    /// </summary>
    [IsoId("_SBq62Np-Ed-ak6NoX_4Aeg_473679595")]
    [DisplayName("Cheque Details")]
    [IsoXmlTag("ChqDtls")]
    public required Cheque4 ChequeDetails { get; init; } 
    
    /// <summary>
    /// Settlement instructions for a payment by draft.
    /// </summary>
    [IsoId("_SB0r0Np-Ed-ak6NoX_4Aeg_530938893")]
    [DisplayName("Bankers Draft Details")]
    [IsoXmlTag("BkrsDrftDtls")]
    public required Cheque4 BankersDraftDetails { get; init; } 
    
    
    #nullable disable
    
}
