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
/// Specifies categories of statuses of a derivative when there is a reporting requirement for both counterparties.
/// </summary>
[IsoId("_IVUQNV55Ee2a_-MvhEjKmA")]
[DisplayName("Reconciliation Category")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationCategory3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationCategory3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationCategory3( TradeRepositoryReportingType1Code reqReportingType,PairingStatus1Code reqPairing,ReconciliationStatus1Code reqReconciliation,ReconciliationStatus2Code reqValuationReconciliation,System.String reqRevived,System.String reqFurtherModification )
    {
        ReportingType = reqReportingType;
        Pairing = reqPairing;
        Reconciliation = reqReconciliation;
        ValuationReconciliation = reqValuationReconciliation;
        Revived = reqRevived;
        FurtherModification = reqFurtherModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicator of receiving only one side or both sides of the derivatives.
    /// </summary>
    [IsoId("_IWQrYV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reporting Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgTp")]
    #endif
    [IsoXmlTag("RptgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeRepositoryReportingType1Code ReportingType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeRepositoryReportingType1Code ReportingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeRepositoryReportingType1Code ReportingType { get; init; } 
    #else
    public TradeRepositoryReportingType1Code ReportingType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of side identification of the same derivative.
    /// </summary>
    [IsoId("_IWQrY155Ee2a_-MvhEjKmA")]
    [DisplayName("Pairing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pairg")]
    #endif
    [IsoXmlTag("Pairg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PairingStatus1Code Pairing { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PairingStatus1Code Pairing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PairingStatus1Code Pairing { get; init; } 
    #else
    public PairingStatus1Code Pairing { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    [IsoId("_IWQrZV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcncltn")]
    #endif
    [IsoXmlTag("Rcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationStatus1Code Reconciliation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationStatus1Code Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationStatus1Code Reconciliation { get; init; } 
    #else
    public ReconciliationStatus1Code Reconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    [IsoId("_IWQrZ155Ee2a_-MvhEjKmA")]
    [DisplayName("Valuation Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRcncltn")]
    #endif
    [IsoXmlTag("ValtnRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationStatus2Code ValuationReconciliation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationStatus2Code ValuationReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationStatus2Code ValuationReconciliation { get; init; } 
    #else
    public ReconciliationStatus2Code ValuationReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    [IsoId("_IWQraV55Ee2a_-MvhEjKmA")]
    [DisplayName("Revived")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvvd")]
    #endif
    [IsoXmlTag("Rvvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Revived { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Revived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Revived { get; init; } 
    #else
    public System.String Revived { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    [IsoId("_IWQra155Ee2a_-MvhEjKmA")]
    [DisplayName("Further Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrthrMod")]
    #endif
    [IsoXmlTag("FrthrMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator FurtherModification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FurtherModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FurtherModification { get; init; } 
    #else
    public System.String FurtherModification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
