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
/// Type of product and assets to be transferred.
/// </summary>
[IsoId("_YUPyz-lfEeu9cf4XM82AQQ")]
[DisplayName("Portfolio Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioTransfer10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PortfolioTransfer10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioTransfer10( System.String reqTransferInstructionReference,System.String reqTransferConfirmationIdentification )
    {
        TransferInstructionReference = reqTransferInstructionReference;
        TransferConfirmationIdentification = reqTransferConfirmationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Yq5YE-lfEeu9cf4XM82AQQ")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_Yq5YFelfEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Instruction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfInstrRef")]
    #endif
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferInstructionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferInstructionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferInstructionReference { get; init; } 
    #else
    public System.String TransferInstructionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_Yq5YF-lfEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfConfId")]
    #endif
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferConfirmationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferConfirmationIdentification { get; init; } 
    #else
    public System.String TransferConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    [IsoId("_Yq5YGelfEeu9cf4XM82AQQ")]
    [DisplayName("Actual Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlTrfDt")]
    #endif
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ActualTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ActualTransferDate { get; init; } 
    #else
    public System.DateOnly? ActualTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_Yq5YG-lfEeu9cf4XM82AQQ")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundPortfolio7Choice_? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundPortfolio7Choice_? Portfolio { get; init; } 
    #else
    public FundPortfolio7Choice_? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_Yq5YHelfEeu9cf4XM82AQQ")]
    [DisplayName("All Other Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOthrCsh")]
    #endif
    [IsoXmlTag("AllOthrCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllOtherCash1? AllOtherCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllOtherCash1? AllOtherCash { get; init; } 
    #else
    public AllOtherCash1? AllOtherCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_Yq5YH-lfEeu9cf4XM82AQQ")]
    [DisplayName("Cash All")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAll")]
    #endif
    [IsoXmlTag("CshAll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAll1? CashAll { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAll1? CashAll { get; init; } 
    #else
    public CashAll1? CashAll { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with
    /// </summary>
    [IsoId("_Yq5YIelfEeu9cf4XM82AQQ")]
    [DisplayName("Residual Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCsh")]
    #endif
    [IsoXmlTag("RsdlCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidualCash2? ResidualCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidualCash2? ResidualCash { get; init; } 
    #else
    public ResidualCash2? ResidualCash { get; set; } 
    #endif
    
    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_Yq5YI-lfEeu9cf4XM82AQQ")]
    [DisplayName("Tax Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDt")]
    #endif
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TaxDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TaxDate { get; init; } 
    #else
    public System.DateOnly? TaxDate { get; set; } 
    #endif
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Yq5YJelfEeu9cf4XM82AQQ")]
    [DisplayName("Payment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDtls")]
    #endif
    [IsoXmlTag("PmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument14? PaymentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument14? PaymentDetails { get; init; } 
    #else
    public PaymentInstrument14? PaymentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_Yq5YJ-lfEeu9cf4XM82AQQ")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument100? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument100? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument100? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_Yq5YKelfEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
