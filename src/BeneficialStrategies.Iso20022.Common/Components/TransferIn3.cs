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
/// Information about a transfer in transaction.
/// </summary>
[IsoId("_RNhhENp-Ed-ak6NoX_4Aeg_-1300755125")]
[DisplayName("Transfer In")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferIn3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferIn3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferIn3( Transfer6 reqTransferDetails,FinancialInstrument13 reqFinancialInstrumentDetails,InvestmentAccount22 reqAccountDetails,DeliverInformation3 reqSettlementDetails )
    {
        TransferDetails = reqTransferDetails;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        AccountDetails = reqAccountDetails;
        SettlementDetails = reqSettlementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_RNhhEdp-Ed-ak6NoX_4Aeg_-1300755106")]
    [DisplayName("Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfDtls")]
    #endif
    [IsoXmlTag("TrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transfer6 TransferDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transfer6 TransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transfer6 TransferDetails { get; init; } 
    #else
    public Transfer6 TransferDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the financial instrument to be received.
    /// </summary>
    [IsoId("_RNhhEtp-Ed-ak6NoX_4Aeg_-1300755012")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument13 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("_RNhhE9p-Ed-ak6NoX_4Aeg_932233695")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount22 AccountDetails { get; init; } 
    #else
    public InvestmentAccount22 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_RNhhFNp-Ed-ak6NoX_4Aeg_-1300755064")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliverInformation3 SettlementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliverInformation3 SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliverInformation3 SettlementDetails { get; init; } 
    #else
    public DeliverInformation3 SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RNhhFdp-Ed-ak6NoX_4Aeg_-1299834998")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
