// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateOrName4Choice
{
    /// <summary>
    /// Pricing expressed as a rate index type or a rate name. Lookback and crystallization days.
    /// </summary>
    [IsoId("_KwKzkxIlEeyLzJfz3xPQNA")]
    [DisplayName("Rate Index Details")]
    public partial record RateIndexDetails : RateOrName4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the rate type as an index type or by its name.
        /// </summary>
        [IsoId("_LIAr0RIlEeyLzJfz3xPQNA")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required BenchmarkCurveName13Choice_ Type { get; init; } 
        
        /// <summary>
        /// Number of days prior to the current day to source the rate.
        /// </summary>
        [IsoId("_LIAr0xIlEeyLzJfz3xPQNA")]
        [DisplayName("Look Back Days")]
        [IsoXmlTag("LookBckDays")]
        [IsoSimpleType(IsoSimpleType.Max3NumericText)]
        public IsoMax3NumericText? LookBackDays { get; init; } 
        
        /// <summary>
        /// Identifies the penultimate accrual date of the transaction to the final (repurchase) date. Crystallising the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day.
        /// </summary>
        [IsoId("_LIAr1RIlEeyLzJfz3xPQNA")]
        [DisplayName("Crystallisation Date")]
        [IsoXmlTag("CrstllstnDt")]
        public CrystallisationDay1? CrystallisationDate { get; init; } 
        
        /// <summary>
        /// Specifies the tenor of the interest rate index (when the interest rate is calculated).
        /// </summary>
        [IsoId("_LIAr1xIlEeyLzJfz3xPQNA")]
        [DisplayName("Tenor")]
        [IsoXmlTag("Tnr")]
        public InterestRateIndexTenor2Code? Tenor { get; init; } 
        
        /// <summary>
        /// Rate Index currency.
        /// </summary>
        [IsoId("_LIAr2RIlEeyLzJfz3xPQNA")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
        
        
        #nullable disable
        
    }
}
