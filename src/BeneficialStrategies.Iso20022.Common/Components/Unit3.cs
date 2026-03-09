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
/// Information about the units to settle.
/// </summary>
[IsoId("_Soaxx9p-Ed-ak6NoX_4Aeg_-1327228212")]
[DisplayName("Unit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Unit3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Unit3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Unit3( FinancialInstrumentQuantity1 reqUnitsNumber )
    {
        UnitsNumber = reqUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_SoaxyNp-Ed-ak6NoX_4Aeg_-1326307153")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date upon which the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_SokiwNp-Ed-ak6NoX_4Aeg_-1326307112")]
    [DisplayName("Acquisition Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqstnDt")]
    #endif
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AcquisitionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AcquisitionDate { get; init; } 
    #else
    public System.DateOnly? AcquisitionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    [IsoId("_Sokiwdp-Ed-ak6NoX_4Aeg_-1326307094")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateNumber { get; init; } 
    #else
    public System.String? CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_Sokiwtp-Ed-ak6NoX_4Aeg_-1326307077")]
    [DisplayName("Group 1 Or 2 Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp1Or2Units")]
    #endif
    [IsoXmlTag("Grp1Or2Units")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    #else
    public UKTaxGroupUnitCode? Group1Or2Units { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the price of the transferred units.
    /// </summary>
    [IsoId("_Sokiw9p-Ed-ak6NoX_4Aeg_-1326307034")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice12? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice12? PriceDetails { get; init; } 
    #else
    public UnitPrice12? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
