// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional count which may be utilised for reconciliation.
/// </summary>
[IsoId("_uP6W4Xu_EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
public partial record TransactionTotals6
{
    #nullable enable
    
    /// <summary>
    /// Sum number of all authorisation transactions.
    /// </summary>
    [IsoId("_A8MP0HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Authorisation { get; init; } 
    
    /// <summary>
    /// Sum number of all reversed authorisation transactions.
    /// </summary>
    [IsoId("_EzJ6UHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Authorisation Reversal")]
    [IsoXmlTag("AuthstnRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AuthorisationReversal { get; init; } 
    
    /// <summary>
    /// Sum number of all inquiry transactions.
    /// </summary>
    [IsoId("_HZdOMHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Inquiry")]
    [IsoXmlTag("Nqry")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Inquiry { get; init; } 
    
    /// <summary>
    /// Sum number of all reversed inquiry transactions.
    /// </summary>
    [IsoId("_KRVaQHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Inquiry Reversal")]
    [IsoXmlTag("NqryRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InquiryReversal { get; init; } 
    
    /// <summary>
    /// Sum number of all financial presentment payment transactions processed.
    /// </summary>
    [IsoId("_NUPxoHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Payments")]
    [IsoXmlTag("Pmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Payments { get; init; } 
    
    /// <summary>
    /// Sum number of all financial presentment payment transactions which have been reversed.
    /// </summary>
    [IsoId("_SAEAgHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Payment Reversal")]
    [IsoXmlTag("PmtRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PaymentReversal { get; init; } 
    
    /// <summary>
    /// Sum number of all financial presentment transactions processed.
    /// </summary>
    [IsoId("_WV0f0HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Transfer")]
    [IsoXmlTag("Trf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Transfer { get; init; } 
    
    /// <summary>
    /// Sum number of all reversal transactions processed.
    /// </summary>
    [IsoId("_aB3TwHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Transfer Reversal")]
    [IsoXmlTag("TrfRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TransferReversal { get; init; } 
    
    /// <summary>
    /// Sum number of all fee collection transactions.
    /// </summary>
    [IsoId("_dOp_4HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Fee Collection")]
    [IsoXmlTag("FeeColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? FeeCollection { get; init; } 
    
    
    #nullable disable
    
}
