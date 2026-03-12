// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the card transaction.
/// </summary>
[IsoId("_PIUQ8Xu4EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Detail")]
public partial record CardTransactionDetail6
{
    #nullable enable
    
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_PU1C8Xu4EeS2Z_kGi7H1VQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount5 TransactionAmounts { get; init; } 
    
    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [IsoId("_4uVxEIN0EeSXtJ8rlirVJw")]
    [DisplayName("Transaction Fees")]
    [IsoXmlTag("TxFees")]
    public DetailedAmount11? TransactionFees { get; init; } 
    
    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("__cFbcIN0EeSXtJ8rlirVJw")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public DetailedAmount10? AdditionalAmounts { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_PU1C-3u4EeS2Z_kGi7H1VQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    
    #nullable disable
    
}
