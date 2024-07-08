interface ToDo_DTO {
  name: string;
  completed: boolean;
  estimatedHours: number;
  categoryId: number;
}

class ToDo {
  //return a list of the dtos that are not completed
  public GetTodos(): ToDo_DTO[] {
    return null;
  }

  //return a list of the names of the dtos that are not completed
  public GetTodoNames(): string[] {
    return null;
  }

  //return the dto with the shortest Estimated Hours
  public GetEasiest(): ToDo_DTO {
    return null;
  }

  private _todos: ToDo_DTO[] = [
    {
      name: "Clean Windows",
      completed: true,
      estimatedHours: 5,
      categoryId: 1,
    },
    {
      name: "Vacume",
      completed: false,
      estimatedHours: 3,
      categoryId: 1,
    },
    {
      name: "Dust",
      completed: false,
      estimatedHours: 1,
      categoryId: 1,
    },
    {
      name: "Grocery Shopping",
      completed: false,
      estimatedHours: 1,
      categoryId: 2,
    },
  ];
}
