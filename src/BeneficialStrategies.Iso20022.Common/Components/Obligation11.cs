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
[IsoId("_KfQr8SgtEeyB747fKu7_rw")]
[DisplayName("Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Obligation11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Obligation11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Obligation11( PartyIdentification242 reqPartyA,PartyIdentification242 reqPartyB,DateAndDateTime2Choice_ reqValuationDate )
    {
        PartyA = reqPartyA;
        PartyB = reqPartyB;
        ValuationDate = reqValuationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement and type of the CCP membership type where the counterparty is a CCP.
    /// </summary>
    [IsoId("_K28zMSgtEeyB747fKu7_rw")]
    [DisplayName("Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyA")]
    #endif
    [IsoXmlTag("PtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification242 PartyA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification242 PartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242 PartyA { get; init; } 
    #else
    public PartyIdentification242 PartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_K28zMygtEeyB747fKu7_rw")]
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
    /// Other entity associated with the collateral agreement and type of the CCP membership type where the counterparty is a CCP.
    /// </summary>
    [IsoId("_K28zNSgtEeyB747fKu7_rw")]
    [DisplayName("Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyB")]
    #endif
    [IsoXmlTag("PtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification242 PartyB { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification242 PartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242 PartyB { get; init; } 
    #else
    public PartyIdentification242 PartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_K28zNygtEeyB747fKu7_rw")]
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
    [IsoId("_K28zOSgtEeyB747fKu7_rw")]
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
    [IsoId("_uh2DAyqWEeyR9JrVGfaMKw")]
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
    [IsoId("_K28zOygtEeyB747fKu7_rw")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType11Code? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType11Code? ExposureType { get; init; } 
    #else
    public ExposureType11Code? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_K28zPSgtEeyB747fKu7_rw")]
    [DisplayName("Valuation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDt")]
    #endif
    [IsoXmlTag("ValtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ValuationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ ValuationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
