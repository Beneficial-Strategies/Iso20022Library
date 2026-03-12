// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRate1Choice
{
    /// <summary>
    /// Provides details about the variable rate.
    /// </summary>
    [IsoId("_Qk1wdNp-Ed-ak6NoX_4Aeg_1389639465")]
    [DisplayName("Variable Interest Rate")]
    public partial record VariableInterestRate : InterestRate1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the index taken into account to calculate the variable interest rate.
        /// </summary>
        [IsoId("_Qk1wcNp-Ed-ak6NoX_4Aeg_-276733537")]
        [DisplayName("Index")]
        [IsoXmlTag("Indx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Index { get; init; } 
        
        /// <summary>
        /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
        /// </summary>
        [IsoId("_Qk1wcdp-Ed-ak6NoX_4Aeg_-1323070567")]
        [DisplayName("Basis Point Spread")]
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? BasisPointSpread { get; init; } 
        
        
        #nullable disable
        
    }
}
