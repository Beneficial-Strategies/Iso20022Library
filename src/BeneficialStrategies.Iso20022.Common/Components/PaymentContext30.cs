// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Context30.
/// </summary>
[IsoId("_fri9QKacEe-I_MmTxsFykg")]
[DisplayName("Payment Context30")]
public partial record PaymentContext30
{
    #nullable enable

    /// <summary>
    /// Credit Transfer Context.
    /// </summary>
    [DisplayName("Credit Transfer Context")]
    [IsoXmlTag("CdtTrfCntxt")]
    public CreditTransferContext1? CreditTransferContext { get; init; } 

    /// <summary>
    /// Direct Debit Context.
    /// </summary>
    [DisplayName("Direct Debit Context")]
    [IsoXmlTag("DrctDbtCntxt")]
    public DirectDebitContext1? DirectDebitContext { get; init; } 

    /// <summary>
    /// Payment Context.
    /// </summary>
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext29? PaymentContext { get; init; } 

    /// <summary>
    /// Sale Context.
    /// </summary>
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext4? SaleContext { get; init; } 

    
    #nullable disable
    
}
