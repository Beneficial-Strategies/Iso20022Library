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
[IsoId("_C5dKU4fuEeevKP8c-ilVhA")]
[DisplayName("ISA Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISATransfer29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ISATransfer29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ISATransfer29( System.String reqTransferIdentification )
    {
        TransferIdentification = reqTransferIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_DKaXY4fuEeevKP8c-ilVhA")]
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
    [IsoId("_DKaXZYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfId")]
    #endif
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferIdentification { get; init; } 
    #else
    public System.String TransferIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_DKaXZ4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfConfId")]
    #endif
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferConfirmationIdentification { get; init; } 
    #else
    public System.String? TransferConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_DKaXaYfuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? ClientReference { get; init; } 
    #else
    public AdditionalReference8? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_DKaXa4fuEeevKP8c-ilVhA")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference8? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_DKaXbYfuEeevKP8c-ilVhA")]
    [DisplayName("Business Flow Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFlowTp")]
    #endif
    [IsoXmlTag("BizFlowTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #else
    public BusinessFlowType1Code? BusinessFlowType { get; set; } 
    #endif
    
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_DKaXb4fuEeevKP8c-ilVhA")]
    [DisplayName("Requested Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTrfDt")]
    #endif
    [IsoXmlTag("ReqdTrfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    #else
    public DateFormat1Choice_? RequestedTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_DKaXcYfuEeevKP8c-ilVhA")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
    #else
    public ISAPortfolio1Choice_? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_DKaXc4fuEeevKP8c-ilVhA")]
    [DisplayName("Residual Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCsh")]
    #endif
    [IsoXmlTag("RsdlCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidualCash1Code? ResidualCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidualCash1Code? ResidualCash { get; init; } 
    #else
    public ResidualCash1Code? ResidualCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_DKaXdYfuEeevKP8c-ilVhA")]
    [DisplayName("All Other Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOthrCsh")]
    #endif
    [IsoXmlTag("AllOthrCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    #else
    public AllOtherCash1Code? AllOtherCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_DKaXd4fuEeevKP8c-ilVhA")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument60? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument60? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument60? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
