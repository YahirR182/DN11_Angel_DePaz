
const Customer = [
    { ID: 1, CustomerName: "Angel Yahir", CustomerLastName: "De Paz Reyes", CustomerDate: new Date("2022-01-03") },
    { ID: 2, CustomerName: "Nili", CustomerLastName: "Crisóstomo Domínguez", CustomerDate: new Date("2023-04-03") },
    { ID: 3, CustomerName: "Anel Michelle", CustomerLastName: "Zetina Ayala", CustomerDate: new Date("2021-02-05") },
    { ID: 4, CustomerName: "Angel Yahir", CustomerLastName: "Hernández Salinas", CustomerDate: new Date("2023-07-24") },
    { ID: 5, CustomerName: "Jorge Armando", CustomerLastName: "Esquivel", CustomerDate: new Date("2023-12-23") }];

const customersList = document.getElementById("customersList");

for (let i = 0; i < Customer.length; i++) {
    const li = document.createElement("li");

    li.innerHTML = `ID: ${Customer[i].ID},  Name: ${Customer[i].CustomerName},  Last Name: ${Customer[i].CustomerLastName},  Date:  ${Customer[i].CustomerDate.toDateString()}`;
    customersList.appendChild(li);
}
