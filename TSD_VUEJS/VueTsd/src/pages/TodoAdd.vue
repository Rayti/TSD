<template>
  <div>
    <form>
      <input v-model="todo.name" placeholder="Todo's name" /><br><br>
      <button @click="validate">Add Todo</button>
    </form>

    <div v-show="!valid">You need to fill up the name field!</div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      todo: {
        name: null,
        checked: false,
      },
      valid: true,
    };
  },
  methods: {
    validate() {
      this.valid = true;
      if (this.todo.name != null) {
        this.$router.push({name:'mainPage', params:{newTodoName: this.todo.name}})
      } else {
        this.valid = false;
        setTimeout(() => {
          this.valid = true;
        }, 3000);
      }
    },
  },
};
</script>
