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
/// Details of the proceeds movements.
/// </summary>
[IsoId("_Ri1Csdp-Ed-ak6NoX_4Aeg_1504216884")]
[DisplayName("Proceeds Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProceedsMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the movement of the cash proceeds.
    /// </summary>
    [IsoId("_Ri1Cstp-Ed-ak6NoX_4Aeg_-2002064127")]
    [DisplayName("Cash Proceeds Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPrcdsMvmntDtls")]
    #endif
    [IsoXmlTag("CshPrcdsMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashProceeds1? CashProceedsMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashProceeds1? CashProceedsMovementDetails { get; init; } 
    #else
    public CashProceeds1? CashProceedsMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the movement of the securities proceeds.
    /// </summary>
    [IsoId("_Ri1Cs9p-Ed-ak6NoX_4Aeg_-2011300771")]
    [DisplayName("Securities Proceeds Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesPrcdsMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesPrcdsMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesProceeds1? SecuritiesProceedsMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesProceeds1? SecuritiesProceedsMovementDetails { get; init; } 
    #else
    public SecuritiesProceeds1? SecuritiesProceedsMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the tax voucher.
    /// </summary>
    [IsoId("_Ri1CtNp-Ed-ak6NoX_4Aeg_-1986363312")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxVoucher1? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxVoucher1? TaxDetails { get; init; } 
    #else
    public TaxVoucher1? TaxDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
