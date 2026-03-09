// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides references to the submitted data set both for the matching application and for the user.
/// </summary>
[IsoId("_RaCTE9p-Ed-ak6NoX_4Aeg_204942196")]
[DisplayName("Data Set Submission References")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetSubmissionReferences3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DataSetSubmissionReferences3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetSubmissionReferences3( System.String reqTransactionIdentification,DocumentIdentification7 reqPurchaseOrderReference,System.String reqForcedMatch )
    {
        TransactionIdentification = reqTransactionIdentification;
        PurchaseOrderReference = reqPurchaseOrderReference;
        ForcedMatch = reqForcedMatch;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_RaCTFNp-Ed-ak6NoX_4Aeg_204942206")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_RaCTFdp-Ed-ak6NoX_4Aeg_-47752600")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provides reference to the transaction for the financial institution that submits the data set.
    /// </summary>
    [IsoId("_RaCTFtp-Ed-ak6NoX_4Aeg_204942227")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubmitterTransactionReference { get; init; } 
    #else
    public System.String? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that this message should force the matching application to match all data sets it has received so far for the transaction identified by the transaction identification.
    /// </summary>
    [IsoId("_RaCTF9p-Ed-ak6NoX_4Aeg_-109669347")]
    [DisplayName("Forced Match")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ForcdMtch")]
    #endif
    [IsoXmlTag("ForcdMtch")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ForcedMatch { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ForcedMatch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ForcedMatch { get; init; } 
    #else
    public System.String ForcedMatch { get; set; } 
    #endif
    
    
    #nullable disable
    
}
