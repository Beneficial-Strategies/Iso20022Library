// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundParameters4Choice
{
    /// <summary>
    /// Report parameters.
    /// </summary>
    [IsoId("_KQCmF2omEeipaMTLlhaKMQ")]
    [DisplayName("Parameters")]
    public partial record Parameters : FundParameters4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Financial instrument for which the report is requested.
        /// </summary>
        [IsoId("_Kf9RY2omEeipaMTLlhaKMQ")]
        [DisplayName("Financial Instrument Details")]
        [IsoXmlTag("FinInstrmDtls")]
        public FinancialInstrument71? FinancialInstrumentDetails { get; init; } 
        
        /// <summary>
        /// Fund management company for which the report is requested.
        /// </summary>
        [IsoId("_Kf9RZWomEeipaMTLlhaKMQ")]
        [DisplayName("Fund Management Company")]
        [IsoXmlTag("FndMgmtCpny")]
        public PartyIdentification139? FundManagementCompany { get; init; } 
        
        /// <summary>
        /// Specifies the date on or after which the information required will have been last updated. Only the most recent versions of the data is required.
        /// </summary>
        [IsoId("_Kf9RZ2omEeipaMTLlhaKMQ")]
        [DisplayName("Date From")]
        [IsoXmlTag("DtFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateFrom { get; init; } 
        
        /// <summary>
        /// Country where the fund has legal domicile.
        /// </summary>
        [IsoId("_Kf9RaWomEeipaMTLlhaKMQ")]
        [DisplayName("Country Of Domicile")]
        [IsoXmlTag("CtryOfDmcl")]
        public CountryCode? CountryOfDomicile { get; init; } 
        
        /// <summary>
        /// Country where the fund is registered for distribution.
        /// </summary>
        [IsoId("_Kf9Ra2omEeipaMTLlhaKMQ")]
        [DisplayName("Registered Distribution Country")]
        [IsoXmlTag("RegdDstrbtnCtry")]
        public CountryCode? RegisteredDistributionCountry { get; init; } 
        
        
        #nullable disable
        
    }
}
