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
/// Specifies the settlement fails and the ranking for a specific financial instrument.
/// </summary>
[IsoId("_Bnkxd40bEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Securities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsSecurities1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsSecurities1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsSecurities1( SecurityIdentification19 reqFinancialInstrumentIdentification,System.String reqRank )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Rank = reqRank;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_QRwG4o0bEemUAO64Q252gQ")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Ranking of the top financial instruments with the highest rate of settlement fails.
    /// </summary>
    [IsoId("_BnlYgY0bEemUAO64Q252gQ")]
    [DisplayName("Rank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rank")]
    #endif
    [IsoXmlTag("Rank")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2NumericText Rank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Rank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Rank { get; init; } 
    #else
    public System.String Rank { get; set; } 
    #endif
    
    
    #nullable disable
    
}
