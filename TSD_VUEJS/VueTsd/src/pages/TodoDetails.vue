<template>
  <div>
      Todo details: <br>
      name: 
    <strong>{{$route.params.todo}}</strong>
    <br>
    <button @click="goBack">go back</button>
  </div>
</template>
<script>
export default {
    props: ["todo"],
  data() {
    return {
     
    };
  },
  methods:{
      goBack(){
          this.$router.push({name:'mainPage'})
      }
  }
};
</script>
