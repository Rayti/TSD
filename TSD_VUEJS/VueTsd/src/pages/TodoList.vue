<template>
  <div>
    <div>Todo List</div>
    <router-link to="add">Add new task</router-link>

    <div v-for="todo in $store.state.todoList"
    :key="todo.id">
    
    <router-link :to= "{name: 'details' , params:{id: todo.id, todo: todo.name}}">{{todo.name}} -></router-link>
    </div>

  <br><br>

    <div>
      <button @click="getDataFromApi">
        Get Data From jsonplaceholder 
     
      </button>
       <div v-for="(todo) in apiTodoList"
    :key="todo.id">
  {{todo.title}} - 
  <span v-if="todo.completed">completed</span><span v-else>not completed</span>
    </div>
    </div>
  </div>
</template>
<script>
import todoList from "../data/todoList.js"
export default {
  data() {
    return {
    //  todoList: todoList
      apiTodoList: [],
    };
  },
  methods:{
    getDataFromApi(){
      fetch('https://jsonplaceholder.typicode.com/todos')
  .then(response => response.json())
  .then(json => this.apiTodoList = json)
    }
  },
  mounted(){
    console.log(todoList);
  },
  beforeRouteEnter (to, from, next) {
  next(vm => {
    if(to.params.newTodoName){
      console.log(vm)
    vm.$store.commit("addTodo",to.params.newTodoName)
    }
  })
}
};
</script>

