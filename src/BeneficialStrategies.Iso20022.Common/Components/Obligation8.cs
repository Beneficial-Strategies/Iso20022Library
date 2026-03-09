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
/// General information about the collateral agreement.
/// </summary>
[IsoId("_G5UkMSW1EeyT3chuyX0PgA")]
[DisplayName("Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Obligation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Obligation8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Obligation8( PartyIdentification178Choice_ reqPartyA,PartyIdentification178Choice_ reqPartyB )
    {
        PartyA = reqPartyA;
        PartyB = reqPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    [IsoId("_HRJ1YSW1EeyT3chuyX0PgA")]
    [DisplayName("Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyA")]
    #endif
    [IsoXmlTag("PtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification178Choice_ PartyA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification178Choice_ PartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_ PartyA { get; init; } 
    #else
    public PartyIdentification178Choice_ PartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_HRJ1YyW1EeyT3chuyX0PgA")]
    [DisplayName("Servicing Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcgPtyA")]
    #endif
    [IsoXmlTag("SvcgPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    #else
    public PartyIdentification178Choice_? ServicingPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Other entity associated with the collateral agreement
    /// </summary>
    [IsoId("_HRJ1ZSW1EeyT3chuyX0PgA")]
    [DisplayName("Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyB")]
    #endif
    [IsoXmlTag("PtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification178Choice_ PartyB { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification178Choice_ PartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_ PartyB { get; init; } 
    #else
    public PartyIdentification178Choice_ PartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_HRJ1ZyW1EeyT3chuyX0PgA")]
    [DisplayName("Servicing Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcgPtyB")]
    #endif
    [IsoXmlTag("SvcgPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    #else
    public PartyIdentification178Choice_? ServicingPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_HRJ1aSW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcctId")]
    #endif
    [IsoXmlTag("CollAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #else
    public CollateralAccount3? CollateralAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_ac_m4yqREeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_HRJ1ayW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType21Choice_? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType21Choice_? ExposureType { get; init; } 
    #else
    public ExposureType21Choice_? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    [IsoId("_HRJ1bSW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTxTp")]
    #endif
    [IsoXmlTag("CollTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; init; } 
    #else
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_HRJ1byW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSd")]
    #endif
    [IsoXmlTag("CollSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralRole1Code? CollateralSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code? CollateralSide { get; init; } 
    #else
    public CollateralRole1Code? CollateralSide { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    [IsoId("_HRJ1cSW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrAmt")]
    #endif
    [IsoXmlTag("XpsrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ExposureAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ExposureAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ExposureAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_HRJ1cyW1EeyT3chuyX0PgA")]
    [DisplayName("Valuation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDt")]
    #endif
    [IsoXmlTag("ValtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValuationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValuationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValuationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_HRJ1dSW1EeyT3chuyX0PgA")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    #else
    public ClosingDate4Choice_? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    [IsoId("_HRJ1dyW1EeyT3chuyX0PgA")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_VWE58CW7EeygjNFjAlVoPA")]
    [DisplayName("Settlement Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrc")]
    #endif
    [IsoXmlTag("SttlmPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SettlementProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SettlementProcess { get; init; } 
    #else
    public GenericIdentification30? SettlementProcess { get; set; } 
    #endif
    
    
    #nullable disable
    
}
