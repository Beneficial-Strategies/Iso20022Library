// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification3Choice
{
    /// <summary>
    /// Provides identification of the margin reporting.
    /// </summary>
    [IsoId("_hY22A8K4EeuFNp8LZAnorg")]
    [DisplayName("Margin Reporting")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginReporting : TransactionIdentification3Choice_
    #else
    public partial class MarginReporting : TransactionIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginReporting instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginReporting( OrganisationIdentification15Choice_ reqReportingCounterparty,PartyIdentification236Choice_ reqOtherCounterparty )
        {
            ReportingCounterparty = reqReportingCounterparty;
            OtherCounterparty = reqOtherCounterparty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_Ecgq4M3OEeuiU4QSC_BouQ")]
        [DisplayName("Technical Record Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechRcrdId")]
        #endif
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_haIoYcK4EeuFNp8LZAnorg")]
        [DisplayName("Reporting Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgCtrPty")]
        #endif
        [IsoXmlTag("RptgCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #else
        public OrganisationIdentification15Choice_ ReportingCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
        /// </summary>
        [IsoId("_haIoY8K4EeuFNp8LZAnorg")]
        [DisplayName("Other Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrCtrPty")]
        #endif
        [IsoXmlTag("OthrCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification236Choice_ OtherCounterparty { get; init; } 
        #else
        public PartyIdentification236Choice_ OtherCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying that the Financial counterparty responsible for reporting on behalf of the other counterparty.
        /// </summary>
        [IsoId("_rOzncMK4EeuFNp8LZAnorg")]
        [DisplayName("Entity Responsible For Report")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NttyRspnsblForRpt")]
        #endif
        [IsoXmlTag("NttyRspnsblForRpt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
        #else
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_haIoZcK4EeuFNp8LZAnorg")]
        [DisplayName("Collateral Portfolio Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollPrtflId")]
        #endif
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? CollateralPortfolioIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CollateralPortfolioIdentification { get; init; } 
        #else
        public System.String? CollateralPortfolioIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
