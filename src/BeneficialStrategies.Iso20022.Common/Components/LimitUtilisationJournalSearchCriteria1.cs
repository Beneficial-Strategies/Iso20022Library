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
/// Defines the criteria used to search for a limit.
/// </summary>
[IsoId("_jOa_4-5NEeCisYr99QEiWA_-1185186372")]
[DisplayName("Limit Utilisation Journal Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitUtilisationJournalSearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitUtilisationJournalSearchCriteria1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitUtilisationJournalSearchCriteria1( System.DateOnly reqJournalActivityDate,SystemPartyIdentification4 reqBilateralLimitCounterpartyIdentification )
    {
        JournalActivityDate = reqJournalActivityDate;
        BilateralLimitCounterpartyIdentification = reqBilateralLimitCounterpartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    [IsoId("_jOa_5O5NEeCisYr99QEiWA_-1661846618")]
    [DisplayName("Limit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtTp")]
    #endif
    [IsoXmlTag("LmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitType4Code? LimitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitType4Code? LimitType { get; init; } 
    #else
    public LimitType4Code? LimitType { get; set; } 
    #endif
    
    /// <summary>
    /// Date upon which journal activity takes place.
    /// </summary>
    [IsoId("_jOkw4O5NEeCisYr99QEiWA_-733934865")]
    [DisplayName("Journal Activity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JrnlActvtyDt")]
    #endif
    [IsoXmlTag("JrnlActvtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate JournalActivityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly JournalActivityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly JournalActivityDate { get; init; } 
    #else
    public System.DateOnly JournalActivityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jOkw4e5NEeCisYr99QEiWA_-766183687")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_jOkw4u5NEeCisYr99QEiWA_658227287")]
    [DisplayName("Limit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtCcy")]
    #endif
    [IsoXmlTag("LmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LimitCurrency { get; init; } 
    #else
    public string? LimitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_jOkw4-5NEeCisYr99QEiWA_-1984336654")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIIdentifier? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwner { get; init; } 
    #else
    public System.String? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_jOkw5O5NEeCisYr99QEiWA_1853746946")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtCtrPtyId")]
    #endif
    [IsoXmlTag("BilLmtCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
