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
/// Certificate and contract reference of a transaction.
/// </summary>
[IsoId("__CcGsbMlEeueudaIbClZbQ")]
[DisplayName("Transaction Certificate Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCertificateContract2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the contract provided as through the date and identification of the contract or through the registered contract identification.
    /// </summary>
    [IsoId("__Da-I7MlEeueudaIbClZbQ")]
    [DisplayName("Contract Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRef")]
    #endif
    [IsoXmlTag("CtrctRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractRegistrationReference2Choice_? ContractReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractRegistrationReference2Choice_? ContractReference { get; init; } 
    #else
    public ContractRegistrationReference2Choice_? ContractReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the amount of the transaction in the currency of the registered contract.
    /// </summary>
    [IsoId("__Da-JbMlEeueudaIbClZbQ")]
    [DisplayName("Transaction Amount In Contract Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmtInCtrctCcy")]
    #endif
    [IsoXmlTag("TxAmtInCtrctCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TransactionAmountInContractCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TransactionAmountInContractCurrency { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TransactionAmountInContractCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Expected shipment date as per registered contract.
    /// </summary>
    [IsoId("__Da-J7MlEeueudaIbClZbQ")]
    [DisplayName("Expected Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdShipmntDt")]
    #endif
    [IsoXmlTag("XpctdShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedShipmentDate { get; init; } 
    #else
    public System.DateOnly? ExpectedShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expected advance payment (or prepayment) return date in case counterparty will not deliver the goods/services.
    /// </summary>
    [IsoId("__Da-KbMlEeueudaIbClZbQ")]
    [DisplayName("Expected Advance Payment Return Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdAdvncPmtRtrDt")]
    #endif
    [IsoXmlTag("XpctdAdvncPmtRtrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedAdvancePaymentReturnDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedAdvancePaymentReturnDate { get; init; } 
    #else
    public System.DateOnly? ExpectedAdvancePaymentReturnDate { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the transaction certificate contract.
    /// </summary>
    [IsoId("__Da-K7MlEeueudaIbClZbQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
