// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementDailyFailureReason1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_UCFuEzOlEeqX8uoQQ3KffQ")]
    [DisplayName("Data")]
    public partial record Data : SettlementDailyFailureReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Fails due to lack of securities.
        /// </summary>
        [IsoId("_MRbYsTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Failed Securities")]
        [IsoXmlTag("FaildScties")]
        public required SettlementTotalData1Choice_ FailedSecurities { get; init; } 
        
        /// <summary>
        /// Fails due to lack of cash.
        /// </summary>
        [IsoId("_MRbYszOmEeqX8uoQQ3KffQ")]
        [DisplayName("Failed Cash")]
        [IsoXmlTag("FaildCsh")]
        public required SettlementTotalData1Choice_ FailedCash { get; init; } 
        
        
        #nullable disable
        
    }
}
