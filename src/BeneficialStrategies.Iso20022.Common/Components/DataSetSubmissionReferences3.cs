// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides references to the submitted data set both for the matching application and for the user.
/// </summary>
[IsoId("_RaCTE9p-Ed-ak6NoX_4Aeg_204942196")]
[DisplayName("Data Set Submission References")]
public partial record DataSetSubmissionReferences3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_RaCTFNp-Ed-ak6NoX_4Aeg_204942206")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_RaCTFdp-Ed-ak6NoX_4Aeg_-47752600")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Provides reference to the transaction for the financial institution that submits the data set.
    /// </summary>
    [IsoId("_RaCTFtp-Ed-ak6NoX_4Aeg_204942227")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubmitterTransactionReference { get; init; } 
    
    /// <summary>
    /// Specifies that this message should force the matching application to match all data sets it has received so far for the transaction identified by the transaction identification.
    /// </summary>
    [IsoId("_RaCTF9p-Ed-ak6NoX_4Aeg_-109669347")]
    [DisplayName("Forced Match")]
    [IsoXmlTag("ForcdMtch")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForcedMatch { get; init; } 
    
    
    #nullable disable
    
}
