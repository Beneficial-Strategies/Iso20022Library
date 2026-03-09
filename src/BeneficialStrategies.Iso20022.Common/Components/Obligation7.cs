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
[IsoId("_Ar7UOAM2EeutW5-TpeYJhA")]
[DisplayName("Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Obligation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Obligation7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Obligation7( PartyIdentification178Choice_ reqPartyA,PartyIdentification178Choice_ reqPartyB )
    {
        PartyA = reqPartyA;
        PartyB = reqPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    [IsoId("_Ar7UPgM2EeutW5-TpeYJhA")]
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
    [IsoId("_Ar7UPAM2EeutW5-TpeYJhA")]
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
    [IsoId("_Ar7UOgM2EeutW5-TpeYJhA")]
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
    [IsoId("_Ar7UPwM2EeutW5-TpeYJhA")]
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
    [IsoId("_Ar7UOQM2EeutW5-TpeYJhA")]
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
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_Ar7UPQM2EeutW5-TpeYJhA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType5Code? ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType5Code? ExposureType { get; init; } 
    #else
    public ExposureType5Code? ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    [IsoId("_6nB9EQM2EeutW5-TpeYJhA")]
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
    [IsoId("_-7dmsQM2EeutW5-TpeYJhA")]
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
    [IsoId("_Vd_YcQM3EeutW5-TpeYJhA")]
    [DisplayName("Exposure Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrAmt")]
    #endif
    [IsoXmlTag("XpsrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection20? ExposureAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20? ExposureAmount { get; init; } 
    #else
    public AmountAndDirection20? ExposureAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_Ar7UOwM2EeutW5-TpeYJhA")]
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
    [IsoId("_eAL4cQM2EeutW5-TpeYJhA")]
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
    [IsoId("_jdq00QM2EeutW5-TpeYJhA")]
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
    
    
    #nullable disable
    
}
