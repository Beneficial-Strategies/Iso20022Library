// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

global using BeneficialStrategies.Iso20022.Choices;
global using BeneficialStrategies.Iso20022.Codesets;
global using BeneficialStrategies.Iso20022.Components;
global using BeneficialStrategies.Iso20022.Framework;
global using BeneficialStrategies.Iso20022.reda;
global using BeneficialStrategies.Iso20022.SimpleTypes;
global using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;
global using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Consumers;
global using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;
global using MassTransit;
global using Microsoft.EntityFrameworkCore;

// The Choices sub-namespace convention (see root CLAUDE.md) means `global using
// BeneficialStrategies.Iso20022.Choices;` above does NOT bring these child namespaces into
// unqualified scope — explicit aliases are required, same as in the Sagas project itself.
global using DateAndDateTime2Choice = BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice;
global using OriginalActivation3Choice = BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice;
global using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;
global using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
