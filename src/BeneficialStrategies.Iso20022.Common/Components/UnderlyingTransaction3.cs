// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("_Pm2ePtp-Ed-ak6NoX_4Aeg_1632211747")]
[DisplayName("Underlying Transaction")]
public partial record UnderlyingTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original cancellation message, to which the resolution refers.
    /// </summary>
    [IsoId("_Pm2eP9p-Ed-ak6NoX_4Aeg_1632211778")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public OriginalGroupInformation24? OriginalGroupInformationAndStatus { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    [IsoId("_Pm2eQNp-Ed-ak6NoX_4Aeg_1632212087")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public OriginalPaymentInformation3? OriginalPaymentInformationAndStatus { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_Pm2eQdp-Ed-ak6NoX_4Aeg_1678385318")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransactionInformation33? TransactionInformationAndStatus { get; init; } 
    
    
    #nullable disable
    
}
